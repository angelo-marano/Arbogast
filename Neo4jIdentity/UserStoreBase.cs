using System;
using Microsoft.AspNetCore.Identity;
using Neo4jClient;

namespace Neo4jIdentity
{

    public abstract class UserStoreBase : IDisposable
    {
        private bool _disposed;
        protected IGraphClient GraphClient { get; }
        protected IdentityErrorDescriber ErrorDescriber { get; }
        protected UserStoreBase(IGraphClient graphClient, IdentityErrorDescriber errorDescriber = null)
        {
            GraphClient = graphClient;
            ErrorDescriber = errorDescriber;
        }

        protected void Dispose(bool isDisposing)
        {
            _disposed = true;
        }

        protected void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().Name);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}