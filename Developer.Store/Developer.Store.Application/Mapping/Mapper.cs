using AutoMapper;
using Developer.Store.Data.Domain.Tables;
using Developer.Store.Domain.Request.Product;
using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.Product;
using Developer.Store.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Application.Mapping
{
    public class Mapper : Profile
    {
        public Mapper() {
            CreateMap<AddressGeolocation, AddressGeolocationRequest>().ReverseMap();
            CreateMap<UserAddress, UserAddressRequest>().ReverseMap();
            CreateMap<UserName, UserNameRequest>().ReverseMap();
            CreateMap<User,UserRequest>().ReverseMap();
            CreateMap<UserResponse,UserRequest>().ReverseMap();
            CreateMap<UserResponse, User>().ReverseMap();

            CreateMap<ProductRating,ProductRatingRequest>().ReverseMap();
            CreateMap<Products, ProductRequest>().ReverseMap();
            CreateMap<ProductRequest,ProductResponse>().ReverseMap();
            CreateMap<Products, ProductResponse>().ReverseMap();

            CreateMap<CartProduct,Domain.Request.Cart.CartProduct>().ReverseMap();
            CreateMap<Cart,Domain.Response.Cart.CartResponse>().ReverseMap();
            CreateMap<Cart,Domain.Request.Cart.CartRequest>().ReverseMap();
            CreateMap<Domain.Response.Cart.CartResponse, Domain.Request.Cart.CartRequest>().ReverseMap();

            CreateMap<SaleProduct, SaleProductRequest>().ReverseMap();
            CreateMap<Sale, SaleRequest>().ReverseMap();
            CreateMap<Domain.Response.Sale.SaleResponse, SaleRequest>().ReverseMap();
            CreateMap<Domain.Response.Sale.SaleResponse, Sale>().ReverseMap();




        }
    }
}
