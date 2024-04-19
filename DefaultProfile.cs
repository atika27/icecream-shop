using AutoMapper;
using newIceCreamShop.DAL.Entities;
using newIceCreamShop.BLL.DTOs.Request;
using newIceCreamShop.BLL.DTOs.Response;
namespace newIceCreamShop.BLL.AutoMapperProfile
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<ProductRequestDTO,Product>();
            CreateMap<Product, ProductResponseDTO>();

            CreateMap<CartRequestDTO, Cart>();
            CreateMap<Cart, CartResponseDTO>();

            CreateMap<OrderDetailRequestDTO, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailResponseDTO>();

            CreateMap<OrderRequestDTO, Order>();
            CreateMap<Order, OrderResponseDTO>();

            CreateMap<AddressRequestDTO, Address>();
            CreateMap<Address, AddressResponseDTO>();

            CreateMap<UserRequestDTO, User>();
            CreateMap<User, UserResponseDTO>();

            CreateMap<LogInRequestDTO, User>();
            CreateMap<User, LogInResponseDTO>();

        }


    }
}
