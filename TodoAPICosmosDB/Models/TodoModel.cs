namespace TodoAPICosmosDB.Models
{
    public class TodoModel
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "text")]
        public string? Text { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "completed")]
        public bool Completed { get; set; }
    }
}
