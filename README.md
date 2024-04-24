# YTDownload
 Yet another app that download videos in youtube
## Download 
[Download](https://github.com/seizue/YTDownload/releases/tag/0.01)

## Getting started
```csharp
   private YouTubeService YouTubeService
   {
       get
       {
           if (youtubeService == null)
           {
               youtubeService = new YouTubeService(new BaseClientService.Initializer()
               {
                   // Place your API Key here
                   ApiKey = "your_API_Key",

                   // Place your Application Name here
                   ApplicationName = "you_application_name"
               });
           }
           return youtubeService;
       }
  }
```

Make sure to replace `"your_API_Key"` and `"your_application_name"` with your actual API key and application name

## Nuget Packages
* [Google.Apis.YouTube.v3](https://www.nuget.org/packages/Google.Apis.YouTube.v3)
* [YoutubeExplode](https://www.nuget.org/packages/YoutubeExplode)

## Screenshot
![Screenshot 2024-04-24 0928164](https://github.com/seizue/YTDownload/assets/25120376/8a26a370-2f58-4a05-8084-78763aa68c3c)

<a target="_blank" href="https://icons8.com/icon/89261/youtube">YouTube</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
