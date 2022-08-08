using Nogheric.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web;
using System.IO;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;

namespace Nogheric.Controllers
{
    
    public class VideoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetVideos(VideoHead videoHead)
        {
            List<VideoDetail> listVideo = new List<VideoDetail>();
            try
            {
                var yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = videoHead.ApiKey }); //{ ApiKey = "AIzaSyCT8kXaxJ2l29vYg4HBdYy36H-PhAH-Teg" });
                var channelsListRequest = yt.Channels.List("contentDetails");
                channelsListRequest.ForUsername = videoHead.Channel; //"mipaltan";
                var channelsListResponse = channelsListRequest.Execute();
                int VideoCount = 1;
                foreach (var channel in channelsListResponse.Items)
                {
                    var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;
                    var nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        var playlistItemsListRequest = yt.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;
                        // Retrieve the list of videos uploaded to the authenticated user's channel.  
                        var playlistItemsListResponse = playlistItemsListRequest.Execute();
                        foreach (var playlistItem in playlistItemsListResponse.Items)
                        {
                            VideoDetail newVideo = new VideoDetail();
                            newVideo.Count = VideoCount;
                            newVideo.Links = "https://www.youtube.com/embed/" + playlistItem.Snippet.ResourceId.VideoId;
                            Console.WriteLine("Sl No={0}", VideoCount);
                            Console.Write("Video ID ={0} ", "https://www.youtube.com/embed/" + playlistItem.Snippet.ResourceId.VideoId);
                            //Console.Write("Video Title ={0} ", playlistItem.Snippet.Title);  
                            //Console.Write("Video Descriptions = {0}", playlistItem.Snippet.Description);  
                            //Console.WriteLine("Video ImageUrl ={0} ", playlistItem.Snippet.Thumbnails.High.Url);  
                            //Console.WriteLine("----------------------");  
                            listVideo.Add(newVideo);
                            VideoCount++;
                        }
                        nextPageToken = playlistItemsListResponse.NextPageToken;
                    }
                    Console.ReadLine();
                }
                videoHead.Details = listVideo;

                return Ok(new { status = 200, message = "Exitoso.", response = videoHead });
            }
            catch (Exception e)
            {
                return Ok(new { status = 400, message = "Error de respuesta." });
            }

        }


    }
}
