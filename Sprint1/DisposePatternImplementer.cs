using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Sprint1
{
    public class DisposePatternImplementer: CloseableResource, IDisposable
    {

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {

                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                }

               if(!disposing) Console.WriteLine("Disposing by GC");
                disposed = true;
            }
        }

        ~DisposePatternImplementer()
        {
            Dispose(false);
        }
    }
}
