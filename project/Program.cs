// See https://aka.ms/new-console-template for more information
using project.Repositories;
using project.Services;
using project.Views;
var repository = new CartRepository();
var service = new CartService(repository);
var view = new CartView(service);
view.ShowAllCarts();