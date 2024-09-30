using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.Product.ApplicationService.ProductManagerModule.Abstracts;

namespace WS.WebAPI.Controllers.Product
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //Thêm

        //Sửa

        //xoá

        //lấy danh sách (có phân trang)

        //lấy theo id
    }
}
