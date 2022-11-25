using BookStoresWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoresWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using var context = new BookStoresDBContext();
            //#get all athors
            //var author = context.Authors.ToList();


            //#get author by id
            //var author = context.Authors.Where(auth => auth.AuthorId == 3).ToList();


            //#add an author 
            //Author authorModel = new Author();
            //authorModel.FirstName = "John";
            //authorModel.LastName = "Smith";

            //context.Authors.Add(authorModel);
            //context.SaveChanges();


            //#Update an author
            //Author authorFromDB = context.Authors.Where(auth => auth.FirstName == "John").FirstOrDefault();
            //authorFromDB.Phone = "777-777-8888";

            //context.SaveChanges();

            //Remove an author
            Author authorFromDB = context.Authors.Where(auth => auth.FirstName == "John").FirstOrDefault();
            context.Authors.Remove(authorFromDB);
            context.SaveChanges();


            //#get author by name
            var author = context.Authors.Where(auth => auth.FirstName == "John").ToList();

            return author;
        }
    }
}