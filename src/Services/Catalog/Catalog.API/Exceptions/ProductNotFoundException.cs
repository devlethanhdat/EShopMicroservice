namespace Catalog.API.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Không Tìm Thấy Sản Phẩm!") { }
    }
}
