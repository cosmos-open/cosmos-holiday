using System.Collections.Generic;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    /// <summary>
    /// Globalization Resource Template
    /// </summary>
    public class EmbeddedResourceTemplate
    {
        /// <summary>
        /// Create a new instance of <see cref="EmbeddedResourceTemplate"/>.
        /// </summary>
        public EmbeddedResourceTemplate()
        {
            Data = new Dictionary<string, Dictionary<string, string>>();
            Note = new Dictionary<string, string>();
        }

        /// <summary>
        /// Create a new instance of <see cref="EmbeddedResourceTemplate"/>.
        /// </summary>
        /// <param name="data"></param>
        public EmbeddedResourceTemplate(Dictionary<string, Dictionary<string, string>> data)
        {
            Data = data;
            Note = new Dictionary<string, string>();
        }

        /// <summary>
        /// Create a new instance of <see cref="EmbeddedResourceTemplate"/>.
        /// </summary>
        /// <param name="template"></param>
        public EmbeddedResourceTemplate(EmbeddedResourceTemplate template)
        {
            Data = template.Data;
            Note = template.Note;
        }

        /// <summary>
        /// Data<br />
        /// key = date or name or other...<br />
        /// value = lang-text pair.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> Data { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        public Dictionary<string, string> Note { get; set; }

        /// <summary>
        /// Template type / Resource type
        /// </summary>
        public int Type = 99;
    }
}