﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Core.Configuration;

namespace Core.Errors
{
    /// <summary>
    /// API Error response based upon the Problem Details class
    /// </summary>
    /// <comments>Modeled after https://tools.ietf.org/html/rfc7807</comments>
    public class Problem
    {
        private List<InvalidParameter> problems;

        public Problem()
        {
            problems = new List<InvalidParameter>();
            Title = @"An error was found in the information submitted.";
        }

        //
        // Summary:
        //     A human-readable explanation specific to this occurrence of the problem.
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        //
        // Summary:
        //     A URI reference that identifies the specific occurrence of the problem.It may
        //     or may not yield further information if dereferenced.
        [JsonPropertyName("instance")]
        public string Instance { get; set; }

        public List<InvalidParameter> InvalidParameters
        {
            get { return problems; }
            set { problems = value; }
        }

        //
        // Summary:
        //     The HTTP status code([RFC7231], Section 6) generated by the origin server for
        //     this occurrence of the problem.
        [JsonConverter(typeof(StringToIntConverter))]
        [JsonPropertyName("status")]
        public int Status { get; set; }

        //
        // Summary:
        //     A short, human-readable summary of the problem type.It SHOULD NOT change from
        //     occurrence to occurrence of the problem, except for purposes of localization(e.g.,
        //     using proactive content negotiation; see[RFC7231], Section 3.4).
        [JsonPropertyName("title")]
        public string Title { get; set; }

        //
        // Summary:
        //     A URI reference [RFC3986] that identifies the problem type. This specification
        //     encourages that, when dereferenced, it provide human-readable documentation for
        //     the problem type (e.g., using HTML [W3C.REC-html5-20141028]). When this member
        //     is not present, its value is assumed to be "about:blank".
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
