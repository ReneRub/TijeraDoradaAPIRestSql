namespace TD.Common.Results
{
    /// <summary>
    /// Standard Result.
    /// </summary>
    /// <typeparam name="T">We use T to specify Parameter type</typeparam>
    public class StandardResult<T>
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the error Message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the data returned.
        /// Object can be the model returned or the List of errors.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T Data { get; set; }
    }
}
