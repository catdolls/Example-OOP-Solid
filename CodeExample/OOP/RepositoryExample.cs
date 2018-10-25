using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP
{
    public interface IBusinessObject
    {
        int Id { get; }
    }

    public class Person : IBusinessObject
    {
        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Address : IBusinessObject
    {
        public Address(int id, string city)
        {
            this.Id = id;
            this.City = city;
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
    }
    public class Post : IBusinessObject
    {
        public Post(int id, string title)
        {
            this.Id = id;
            this.Title = title;
            this.CreatedDate = DateTime.Now.AddDays(id);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public interface IRepository<T> where T : IBusinessObject
    {
        T Get(int id);
        void Save(T obj);
        void Delete(T obj);
    }

    public class Repository<T> : IRepository<T> where T : class, IBusinessObject
    {
        protected IList<T> list = new List<T>(); 

        public Repository(IList<T> list)
        {
            this.list = list;
        }

        public T Get(int id)
        {
            return this.list.FirstOrDefault(x => x.Id == id);
        }
        public void Save(T obj)
        {
            Console.WriteLine("Save");
        }
        public void Delete(T obj)
        {
            Console.WriteLine("Delete");
        }
    }

    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetRecentPosts();
    }

    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(IList<Post> list) : base(list)
        {
        }
        
        public IEnumerable<Post> GetRecentPosts()
        {
            return this.list.OrderByDescending(x => x.CreatedDate);
        }
    }

    public class RepositorySetup
    {
        private IList<Person> persons = new List<Person>();
        private IList<Address> addresses = new List<Address>();
        private IList<Post> posts = new List<Post>();

        public Repository<Person> PersonRepository { get; set; }
        public Repository<Address> AddressRepository { get; set; }
        public IPostRepository PostRepository { get; set; }

        public RepositorySetup()
        {
            this.persons.Add(new Person(1, "John"));
            this.persons.Add(new Person(2, "Wick"));
            this.persons.Add(new Person(3, "Duck"));

            this.addresses.Add(new Address(1, "Chiang Mai"));
            this.addresses.Add(new Address(2, "Bangkok"));
            this.addresses.Add(new Address(3, "Phuket"));

            this.posts.Add(new Post(1, "Title 1"));
            this.posts.Add(new Post(2, "Title 2"));
            this.posts.Add(new Post(3, "Title 3"));

            this.PersonRepository = new Repository<Person>(this.persons);
            this.AddressRepository = new Repository<Address>(this.addresses);
            this.PostRepository = new PostRepository(this.posts);
            
        }

        public void TestRepository()
        {
            Person person = this.PersonRepository.Get(2);
            Console.WriteLine(person.Id + " : " + person.Name);

            Address address = this.AddressRepository.Get(3);
            Console.WriteLine(address.Id + " : " + address.City);

            Post post1 = this.PostRepository.Get(1);
            Console.WriteLine(post1.Id + " : " + post1.Title);

            IList<Post> recentPosts = this.PostRepository.GetRecentPosts().ToList();
            foreach(Post post in recentPosts)
            {
                Console.WriteLine(post.Id + " : " + post.Title + " : " + post.CreatedDate.ToShortDateString());
            }
        }
    }
}
