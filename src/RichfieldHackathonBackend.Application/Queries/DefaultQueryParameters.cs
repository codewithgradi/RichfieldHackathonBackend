public class DefaultQueryParameters
{
    private int _page = 1;
    private int _size = 10;
    private int _mazSize = 15;

    public int Page
    {
        get
        {
            return _page;
        }
        set
        {
            _page = _page <= 0 ? 1 : value;
        }
    }
    public int PageSize
    {
        get
        {
            return _size;
        }
        set
        {
            _size = value <= 0 ? 10 : Math.Min(value, _mazSize);
        }
    }
    public string? SortOder { get; set; } = "asc";

    public string? SortBy { get; set; }
}