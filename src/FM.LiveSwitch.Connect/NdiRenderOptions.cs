﻿using CommandLine;

namespace FM.LiveSwitch.Connect
{
    [Verb("ndirender", HelpText = "Renders remote media to an ndi stream.")]
    class NdiRenderOptions : ReceiveOptions
    {
        [Option("ndi-name", Required = false, Default = "LiveswitchConnect", HelpText = "Name of the NDI stream")]
        public string NdiName { get; set; }

        [Option("audio-clock-rate", Required = false, Default = 48000, HelpText = "The audio clock rate in Hz. Must be a multiple of 8000. Minimum value is 8000. Maximum value is 48000.")]
        public int AudioClockRate { get; set; }

        [Option("audio-channel-count", Required = false, Default = 2, HelpText = "The audio channel count. Minimum value is 1. Maximum value is 2.")]
        public int AudioChannelCount { get; set; }

        [Option("audio-frame-duration", Required = false, Default = 20, HelpText = "The audio frame duration in milliseconds. Minimum value is 5. Maximum value is 100.")]
        public int AudioFrameDuration { get; set; }

        [Option("video-format", Required = false, Default = ImageFormat.Bgr, HelpText = "The video format.")]
        public ImageFormat VideoFormat { get; set; }
        
        [Option("video-width", Required = false, Default = 800, HelpText = "The video width.")]
        public int VideoWidth { get; set; }

        [Option("video-height", Required = false, Default = 800, HelpText = "The video height.")]
        public int VideoHeight { get; set; }
    }
}
