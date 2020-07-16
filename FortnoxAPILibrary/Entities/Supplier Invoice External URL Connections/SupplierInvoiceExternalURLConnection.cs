using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

namespace FortnoxAPILibrary.Entities
{
    [Entity(SingularName = "SupplierInvoiceExternalURLConnection", PluralName = "SupplierInvoiceExternalURLConnections")]
    public class SupplierInvoiceExternalURLConnection
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public string Url { get; private set; }

        ///<summary> Id of the connection </summary>
        [ReadOnly]
        [JsonProperty]
        public long? Id { get; private set; }

        ///<summary> Supplier invoice number </summary>
        [JsonProperty]
        public long? SupplierInvoiceNumber { get; set; }

        ///<summary> URL of the connection </summary>
        [JsonProperty]
        public string ExternalURLConnection { get; set; }
    }
}