using System;
using System.Threading.Tasks;

namespace AsyncAndParallel
{
    public static class Extensions
    {
        public static async void SafeFireAndForget(this Task task, 
            bool continueOnCapturedContext = true, 
            Action<Exception> exceptionHandler = null)
        {
            try
            {
                await task.ConfigureAwait(continueOnCapturedContext);
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
            }
        }
    }
}
