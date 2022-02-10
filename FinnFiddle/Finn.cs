#pragma warning disable IDE1006 // Naming Styles
namespace Finn;

public class FinnResponse
{
    public Doc[] docs { get; set; }
    public Filter[] filters { get; set; }
    public Metadata metadata { get; set; }
    public string mapUrl { get; set; }
    public bool isOdin { get; set; }
    public Pagemetadata pageMetadata { get; set; }
    public string resultHeading { get; set; }
}

public class Metadata
{
    public Params _params { get; set; }
    public string search_key { get; set; }
    public object[] selected_filters { get; set; }
    public int num_results { get; set; }
    public int quest_time { get; set; }
    public int solr_time { get; set; }
    public int solr_elapsed_time { get; set; }
    public Result_Size result_size { get; set; }
    public Paging paging { get; set; }
    public string title { get; set; }
    public bool is_savable_search { get; set; }
    public string search_key_description { get; set; }
    public string vertical { get; set; }
    public string vertical_description { get; set; }
    public string sort { get; set; }
    public string uuid { get; set; }
    public Tracking tracking { get; set; }
    public Guided_Search guided_search { get; set; }
    public bool is_end_of_paging { get; set; }
}

public class Params
{
    public string[] q { get; set; }
    public string[] sort { get; set; }
}

public class Result_Size
{
    public int match_count { get; set; }
    public int group_count { get; set; }
}

public class Paging
{
    public string param { get; set; }
    public int current { get; set; }
    public int last { get; set; }
}

public class Tracking
{
    public Object _object { get; set; }
    public Vertical vertical { get; set; }
}

public class Object
{
    public Filters filters { get; set; }
    public object[] selectionFilters { get; set; }
    public string sortingType { get; set; }
    public int numItems { get; set; }
    public int pageNumber { get; set; }
    public string layout { get; set; }
    public string type { get; set; }
}

public class Filters
{
    public string query { get; set; }
}

public class Vertical
{
    public string name { get; set; }
}

public class Guided_Search
{
    public object[] suggestions { get; set; }
    public Tracking1 tracking { get; set; }
}

public class Tracking1
{
    public Search search { get; set; }
    public Vertical1 vertical { get; set; }
    public string name { get; set; }
    public string intent { get; set; }
    public string type { get; set; }
}

public class Search
{
    public object[] items { get; set; }
    public string originalQuery { get; set; }
    public string type { get; set; }
    public string id { get; set; }
}

public class Vertical1
{
    public string name { get; set; }
}

public class Pagemetadata
{
    public string title { get; set; }
    public string description { get; set; }
    public string indexDirective { get; set; }
    public string canonicalUrl { get; set; }
    public string openGraphUrl { get; set; }
    public Jsonld jsonLd { get; set; }
    public string image { get; set; }
}

public class Jsonld
{
    public string context { get; set; }
    public string type { get; set; }
    public string url { get; set; }
    public Maincontentofpage mainContentOfPage { get; set; }
    public Breadcrumb breadcrumb { get; set; }
    public string headline { get; set; }
}

public class Maincontentofpage
{
    public string type { get; set; }
    public string cssSelector { get; set; }
}

public class Breadcrumb
{
    public string type { get; set; }
    public string name { get; set; }
    public Itemlistelement[] itemListElement { get; set; }
}

public class Itemlistelement
{
    public string type { get; set; }
    public int position { get; set; }
    public Item item { get; set; }
}

public class Item
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Doc
{
    public string type { get; set; }
    public int ad_id { get; set; }
    public string main_search_key { get; set; }
    public string heading { get; set; }
    public string location { get; set; }
    public Image image { get; set; }
    public string[] flags { get; set; }
    public long timestamp { get; set; }
    public Coordinates coordinates { get; set; }
    public Price price { get; set; }
    public int distance { get; set; }
    public string trade_type { get; set; }
    public string ad_link { get; set; }

    public override string ToString()
    {
        return $"[ID: {ad_id}, Heading: {heading}, TradeType: {trade_type}, Link: {ad_link}, Price: {price?.amount}]";
    }
}

public class Image
{
    public string url { get; set; }
    public string path { get; set; }
    public int height { get; set; }
    public int width { get; set; }
    public float aspect_ratio { get; set; }
}

public class Coordinates
{
    public float lat { get; set; }
    public float lon { get; set; }
}

public class Price
{
    public int amount { get; set; }
    public string currency_code { get; set; }
}

public class Filter
{
    public string display_name { get; set; }
    public string name { get; set; }
    public Filter_Items[] filter_items { get; set; }
    public string value { get; set; }
    public string gs_value { get; set; }
    public string type { get; set; }
    public int min_value { get; set; }
    public int max_value { get; set; }
    public int step { get; set; }
    public string unit { get; set; }
    public string name_from { get; set; }
    public string name_to { get; set; }
    public bool is_year { get; set; }
}

public class Filter_Items
{
    public string display_name { get; set; }
    public string name { get; set; }
    public string value { get; set; }
    public int hits { get; set; }
    public bool selected { get; set; }
    public Filter_Items1[] filter_items { get; set; }
}

public class Filter_Items1
{
    public string display_name { get; set; }
    public string name { get; set; }
    public string value { get; set; }
    public int hits { get; set; }
    public Filter_Items2[] filter_items { get; set; }
    public bool selected { get; set; }
}

public class Filter_Items2
{
    public string display_name { get; set; }
    public string name { get; set; }
    public string value { get; set; }
    public int hits { get; set; }
    public object[] filter_items { get; set; }
    public bool selected { get; set; }
}
#pragma warning restore IDE1006 // Naming Styles