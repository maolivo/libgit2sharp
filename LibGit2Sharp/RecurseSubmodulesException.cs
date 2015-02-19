using System;
using System.Runtime.Serialization;

namespace LibGit2Sharp
{
    /// <summary>
    /// The exception that is thrown when an error is encountered while recursing through submodules.
    /// The inner exception contains the exception that was initially thrown while operating on the submodule.
    /// </summary>
    [Serializable]
    public class RecurseSubmodulesException : LibGit2SharpException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousSpecificationException"/> class.
        /// </summary>
        public RecurseSubmodulesException()
        {
        }

        /// <summary>
        /// The path to the initial repository the operation was run on.
        /// </summary>
        public virtual string ParentRepoPath { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurseSubmodulesException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        /// <param name="parentRepoPath">The path to the initial repository the operation was performed on.</param>
        public RecurseSubmodulesException(string message, string parentRepoPath)
            : base(message)
        {
            ParentRepoPath = parentRepoPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurseSubmodulesException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="parentRepoPath">The path to the initial repository the operation was performed on.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public RecurseSubmodulesException(string message, string parentRepoPath, Exception innerException)
            : base(message, innerException)
        {
            ParentRepoPath = parentRepoPath;
        }
    }
}
