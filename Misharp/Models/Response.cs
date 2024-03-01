using System.Net;

namespace Misharp.Model
{
    public class Response<T> where T : class
    {
        private T? _data { get; set; }
        public T Result
        {
            get
            {
                if (_data == null) throw new NullReferenceException();
                return _data;
            }
        }
        public HttpStatusCode StatusCode { get; set; }
        public Response(HttpStatusCode statusCode, T? data = null)
        {
            this._data = data;
            this.StatusCode = statusCode;
        }
        public bool IsNull()
        {
            return _data == null;
        }
    }

    public class EmptyResponse
    {

    }
}
