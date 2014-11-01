﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using Gitter.Models;
using ModernHttpClient;
using Newtonsoft.Json.Linq;
using Refit;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}

namespace Gitter
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIGitterApi : IGitterApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIGitterApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual IObservable<IReadOnlyList<Message>> GetMessages(string roomId,string accessToken)
        {
            var arguments = new object[] { roomId,accessToken };
            return (IObservable<IReadOnlyList<Message>>) methodImpls["GetMessages"](Client, arguments);
        }

        public virtual Task<IReadOnlyList<Room>> GetRooms(string accessToken)
        {
            var arguments = new object[] { accessToken };
            return (Task<IReadOnlyList<Room>>) methodImpls["GetRooms"](Client, arguments);
        }

        public virtual Task<Unit> SendMessage(string roomId,SendMessage message,string accessToken)
        {
            var arguments = new object[] { roomId,message,accessToken };
            return (Task<Unit>) methodImpls["SendMessage"](Client, arguments);
        }

    }
}


