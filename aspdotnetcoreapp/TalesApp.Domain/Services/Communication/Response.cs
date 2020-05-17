namespace TalesApp.Domain.Services.Communication
{
    /// <summary>
    /// Response generator
    /// </summary>
    /// <param name="T">This is a Db object</param>
    public class Response<T> : BaseResponse
    {
        public T DbObject { get; private set; }

        private Response(bool success, string message, T dBObject) : base(success, message)
        {
            DbObject = dBObject;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="storySetsSequence"></param>
        /// <returns>Response.</returns>
        public Response(T dBObject) : this(true, string.Empty, dBObject)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public Response(string message) : this(false, message, default(T))
        { }
    }
}
