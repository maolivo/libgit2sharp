using System.Collections.Generic;
namespace LibGit2Sharp
{
    /// <summary>
    /// All supported hook types. See the comment for each type
    /// to find the hook file name associated with it.
    /// </summary>
    public enum HookType
    {
        /// <summary>
        /// applypatch-msg
        /// </summary>
        ApplyPatchMsg = 0,

        /// <summary>
        /// commit-msg
        /// </summary>
        CommitMsg,

        /// <summary>
        /// post-applypatch
        /// </summary>
        PostApplyPatch,

        /// <summary>
        /// post-checkout
        /// </summary>
        PostCheckout,

        /// <summary>
        /// post-commit
        /// </summary>
        PostCommit,

        /// <summary>
        /// post-merge
        /// </summary>
        PostMerge,

        /// <summary>
        /// post-receive
        /// </summary>
        PostReceive,
        
        /// <summary>
        /// post-rewrite
        /// </summary>
        PostRewrite,

        /// <summary>
        /// post-update
        /// </summary>
        PostUpdate,

        /// <summary>
        /// prepare-commit-msg
        /// </summary>
        PrepareCommitMsg,

        /// <summary>
        /// pre-applypatch
        /// </summary>
        PreApplyPatch,

        /// <summary>
        /// pre-auto-gc
        /// </summary>
        PreAutoGC,

        /// <summary>
        /// pre-commit
        /// </summary>
        PreCommit,

        /// <summary>
        /// pre-push
        /// </summary>
        PrePush,

        /// <summary>
        /// pre-rebase
        /// </summary>
        PreRebase,

        /// <summary>
        /// pre-receive
        /// </summary>
        PreReceive,

        /// <summary>
        /// pre-update
        /// </summary>
        Update,
    }

    /// <summary>
    /// A hook for a repository.
    /// </summary>
    public class Hook
    {
        /// <summary>
        /// The type of hook.
        /// </summary>
        public HookType Type { get; private set; }

        /// <summary>
        /// Whether the hook file exists inside the repository.
        /// </summary>
        public bool Exists { get; private set; }

        /// <summary>
        /// The full path to the hook file.
        /// </summary>
        public string Path { get; private set; }

        private readonly Repository repo;

        /// <summary>
        /// Needed for mocking purposes.
        /// </summary>
        protected Hook()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hook"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        /// <param name="type">The type of hook.</param>
        internal Hook(Repository repo, HookType type)
        {
            this.repo = repo;
            this.Type = type;

            this.DetectIfHookFileExists();
        }

        /// <summary>
        /// Determines if the hook file exists and updates this object accordingly.
        /// </summary>
        protected void DetectIfHookFileExists()
        {

        }
    }
}
