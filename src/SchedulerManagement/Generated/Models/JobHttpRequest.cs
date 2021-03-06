// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Request for an http or https action type.
    /// </summary>
    public partial class JobHttpRequest
    {
        private HttpAuthentication _authentication;
        
        /// <summary>
        /// Optional. Gets or sets the request authentication.
        /// </summary>
        public HttpAuthentication Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }
        
        private string _body;
        
        /// <summary>
        /// Optional. Gets or sets the request body.
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }
        
        private IDictionary<string, string> _headers;
        
        /// <summary>
        /// Optional. Gets or sets Header name value pairs to supply with the
        /// http/https action.
        /// </summary>
        public IDictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }
        
        private string _method;
        
        /// <summary>
        /// Required. Gets or sets Http method e.g. GET, PUT, POST, DELETE.
        /// </summary>
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }
        
        private Uri _uri;
        
        /// <summary>
        /// Required. Gets or sets Uri of the endpoint to invoke.
        /// </summary>
        public Uri Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobHttpRequest class.
        /// </summary>
        public JobHttpRequest()
        {
            this.Headers = new Dictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the JobHttpRequest class with
        /// required arguments.
        /// </summary>
        public JobHttpRequest(Uri uri, string method)
            : this()
        {
            if (uri == null)
            {
                throw new ArgumentNullException("uri");
            }
            if (method == null)
            {
                throw new ArgumentNullException("method");
            }
            this.Uri = uri;
            this.Method = method;
        }
    }
}
