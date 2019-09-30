using System.Threading;
using System.Threading.Tasks;
using Imparta.Xamarin.Forms.VideoPlayer.Interfaces;

namespace Imparta.Xamarin.Forms.VideoPlayer.UWP.SourceHandlers
{
    public sealed class FileVideoSourceHandler : IVideoSourceHandler
    {
        /// <summary>
        /// Loads the video from the specified source.
        /// </summary>
        /// <param name="source">The source of the video file.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The path to the video file.</returns>
        public Task<string> LoadVideoAsync(VideoSource source, CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = null;
            var fileVideoSource = source as FileVideoSource;
            
            if (!string.IsNullOrEmpty(fileVideoSource?.File))
            {
                path = fileVideoSource.File;
            }

            return Task.FromResult(path);
        }
    }
}
