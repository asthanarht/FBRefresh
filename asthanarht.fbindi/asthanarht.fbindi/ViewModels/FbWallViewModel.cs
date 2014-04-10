using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace asthanarht.fbindi.ViewModels
{
    public class FbWallViewModel
    {

        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("paging")]
        public Paging3 Paging { get; set; }
    }

    public class CategoryList
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class From
    {

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category_list")]
        public CategoryList[] CategoryList { get; set; }
    }

    public class Action
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Privacy
    {

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Shares
    {

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class Datum2
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Cursors
    {

        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("before")]
        public string Before { get; set; }
    }

    public class Paging
    {

        [JsonProperty("cursors")]
        public Cursors Cursors { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class Likes
    {

        [JsonProperty("data")]
        public Datum2[] Data { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class From2
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class MessageTag
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }

    public class Datum3
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("from")]
        public From2 From { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("can_remove")]
        public bool CanRemove { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("like_count")]
        public int LikeCount { get; set; }

        [JsonProperty("user_likes")]
        public bool UserLikes { get; set; }

        [JsonProperty("message_tags")]
        public MessageTag[] MessageTags { get; set; }
    }

    public class Cursors2
    {

        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("before")]
        public string Before { get; set; }
    }

    public class Paging2
    {

        [JsonProperty("cursors")]
        public Cursors2 Cursors { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class Comments
    {

        [JsonProperty("data")]
        public Datum3[] Data { get; set; }

        [JsonProperty("paging")]
        public Paging2 Paging { get; set; }
    }

    public class Application
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Property
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Datum
    {
        
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("from")]
        public From From { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

        [JsonProperty("privacy")]
        public Privacy Privacy { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status_type")]
        public string StatusType { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("updated_time")]
        public string UpdatedTime { get; set; }

        [JsonProperty("shares")]
        public Shares Shares { get; set; }

        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("story")]
        public string Story { get; set; }

        [JsonProperty("properties")]
        public Property[] Properties { get; set; }

        public Datum()
        {
            this.Picture = string.Empty;
        }
    }

    public class Paging3
    {

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

   


}