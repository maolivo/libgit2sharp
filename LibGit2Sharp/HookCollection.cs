using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibGit2Sharp
{
    /// <summary>
    /// The set of hooks in a repository.
    /// </summary>
    public class HookCollection
    {
        private readonly Repository repo;

        /// <summary>
        /// Needed for mocking purposes.
        /// </summary>
        protected HookCollection()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookCollection"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        internal HookCollection(Repository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Gets the <see cref="Hook"/> associated with the <paramref name="HookType"/>.
        /// 
        /// Because a hook file can change, be added, or removed during git operations, we want
        /// to query for the hook file every time we request the <see cref="HookType"/>.
        /// </summary>
        /// <param name="type">The type of <see cref="Hook"/>.</param>
        /// <returns><c>null</c> if nothing has been found, the <see cref="Hook"/> otherwise.</returns>
        public Hook this[HookType type]
        {
            get
            {
                return new Hook(repo, type);
            }
        }
    }
}
