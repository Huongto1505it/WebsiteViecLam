using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteJob.Data.Infrastructure
{
   public class Disposable : IDisposable
    {
        
        private bool disposedValue;

        ~Disposable()
        {
            Dispose(false);
        }
        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    DisposeCore();
                }

                disposedValue = true;
            }
        }

        protected virtual void DisposeCore()
        {
        }

        public void Dispose()
        {
            
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
