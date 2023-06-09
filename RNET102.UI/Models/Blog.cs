using Microsoft.EntityFrameworkCore;
using RNET102.UI.Data;
using RNET102.UI.Models;

namespace RNET102.UI.Models;

public class Blog
{
        public int Id { get; set; }
	public string ImageURL { get; set; } = null!;
        public DateTime PublishDate { get; set; }
	public string Title { get; set; } = null!;
	public string Content { get; set; } = null !;
    }

public static class Seed
{
	private static List<Blog> BlogSeedData { get; set; } = new()
	{
		new Blog{Title="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut sit amet cursus odio.", Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut sit amet cursus odio. Vivamus ut ornare velit. Phasellus auctor ut ante sed hendrerit. Vestibulum accumsan dignissim purus sed molestie. Donec vitae eros et arcu sagittis ultrices. Vivamus nec suscipit lectus. Donec id ullamcorper lacus. Pellentesque finibus feugiat commodo. Sed diam velit, mollis in nisi vel, elementum consequat arcu. Curabitur ac mauris diam. Etiam nec lorem in diam condimentum commodo. Sed molestie massa ut tellus lacinia porttitor. Sed at dolor urna.", ImageURL="https://plus.unsplash.com/premium_photo-1680871320511-8be2085ff281?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=659&q=80", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Vivamus ut ornare velit. Phasellus auctor ut ante sed hendrerit.", Content="Quisque pellentesque tristique venenatis. Fusce eget finibus velit, vel tincidunt ex. Aliquam vitae pulvinar magna. Phasellus porta lacus eu finibus sollicitudin. Phasellus sit amet dictum tellus. Phasellus condimentum cursus purus, ut aliquet lorem rhoncus vitae. Fusce sed lobortis odio. Pellentesque dictum, lectus vitae ornare pharetra, dui elit tempus neque, eu rutrum sem ante in arcu. In dictum elit sit amet erat elementum efficitur. Sed vel ante nibh. Suspendisse sollicitudin eleifend mi a facilisis. Morbi facilisis, ligula eu vestibulum efficitur, risus nisi tristique enim, vitae dictum metus nisl vitae dui. Aenean consectetur erat purus, at mollis lorem facilisis in. Mauris mi magna, tempor non magna ut, imperdiet rhoncus tellus. Aliquam non dolor massa. Vestibulum enim sem, rutrum eget suscipit maximus, tempor eget libero.", ImageURL="https://images.unsplash.com/photo-1498462440456-0dba182e775b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Vestibulum accumsan dignissim purus sed molestie.", Content="Nulla sed consectetur mauris. Morbi consequat at lacus hendrerit fringilla. Cras quis elementum nisl. Cras at est justo. Mauris nec viverra diam. Pellentesque at molestie ex. Aliquam non sapien ac arcu fermentum vehicula. Donec nisi neque, dignissim porttitor elit porta, bibendum interdum erat. Nam nec neque nec felis varius efficitur ac eu lacus. Morbi gravida tempor blandit. Maecenas rutrum orci in vestibulum pulvinar. Proin hendrerit aliquet lacus ut commodo. Donec dapibus porta ex. Phasellus mollis, metus eu vehicula pretium, metus nisi blandit diam, nec varius felis libero eu metus. Mauris eget efficitur augue.", ImageURL="https://images.unsplash.com/photo-1594897030264-ab7d87efc473?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Donec vitae eros et arcu sagittis ultrices. Vivamus nec suscipit lectus. Donec id", Content="Vestibulum accumsan dignissim purus sed molestie. Donec vitae eros et arcu sagittis ultrices. Vivamus nec suscipit lectus. Donec id ullamcorper lacus. Pellentesque finibus feugiat commodo. Sed diam velit, mollis in nisi vel, elementum consequat arcu. Curabitur ac mauris diam. Etiam nec lorem in diam condimentum commodo. Sed molestie massa ut tellus lacinia porttitor. Sed at dolor urna.\r\n\r\nQuisque pellentesque tristique venenatis. Fusce eget finibus velit, vel tincidunt ex. Aliquam vitae pulvinar magna. Phasellus porta lacus eu finibus sollicitudin. Phasellus sit amet dictum tellus. Phasellus condimentum cursus purus, ut aliquet lorem rhoncus vitae. Fusce sed lobortis odio.", ImageURL="https://media.istockphoto.com/id/1370481100/photo/the-rabbit.jpg?s=2048x2048&w=is&k=20&c=2SAq5QjLZftlKbK-2Mtl3D4GoE6HhPELkLymM1ezzwE=", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Ullamcorper lacus. Pellentesque finibus feugiat commodo. Sed diam velit.", Content="Ut mattis nisl eget sem vestibulum rhoncus. Morbi malesuada nisi ex, ac lobortis lectus egestas et. Suspendisse luctus ullamcorper orci quis fringilla. Nulla volutpat convallis urna eu pellentesque. Mauris finibus, lacus non dictum finibus, eros orci volutpat dolor, ut luctus dolor arcu ac ante. Donec in mollis augue. Nunc congue dictum enim sit amet ultrices. Donec consectetur felis ac odio rhoncus, ac mattis sem aliquet. Proin fringilla commodo ante, ut auctor risus semper ut. Morbi ut nulla pretium, pretium turpis vel, tincidunt urna.", ImageURL="https://images.unsplash.com/photo-1504060765228-f97d1772ff9e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Mollis in nisi vel, elementum consequat arcu. Curabitur.", Content="Proin porttitor finibus ultricies. Ut luctus sem lectus, sit amet sodales massa fermentum et. Nullam in suscipit sem, quis vulputate dolor. Vivamus ornare imperdiet tortor et tempus. Cras nec consequat est. In cursus nulla purus, id sodales lacus egestas et. Vivamus nunc odio, luctus quis dapibus in, cursus id lectus. Aliquam tincidunt mattis mi fringilla tempus. Mauris placerat commodo mauris vel vehicula. Cras interdum mauris quis eros mollis placerat. Aliquam id pharetra nulla, ut vehicula magna.", ImageURL="https://media.istockphoto.com/id/1370678625/photo/neon-rainbow-watercolor-banner-background-on-black-pure-neon-watercolor-colors-creative-paint.jpg?s=2048x2048&w=is&k=20&c=p6uktJXEMviCPLk4-yKtUotlDxd8TToIGZO1wx7LA4g=", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Ac mauris diam. Etiam nec lorem in diam condimentum commodo.", Content="Sed vel ante nibh. Suspendisse sollicitudin eleifend mi a facilisis. Morbi facilisis, ligula eu vestibulum efficitur, risus nisi tristique enim, vitae dictum metus nisl vitae dui. Aenean consectetur erat purus, at mollis lorem facilisis in. Mauris mi magna, tempor non magna ut, imperdiet rhoncus tellus. Aliquam non dolor massa. Vestibulum enim sem, rutrum eget suscipit maximus, tempor eget libero.\r\n\r\nNulla sed consectetur mauris. Morbi consequat at lacus hendrerit fringilla. Cras quis elementum nisl. Cras at est justo. Mauris nec viverra diam. Pellentesque at molestie ex. Aliquam non sapien ac arcu fermentum vehicula. Donec nisi neque, dignissim porttitor elit porta, bibendum interdum erat. ", ImageURL="https://images.unsplash.com/photo-1594372365401-3b5ff14eaaed?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2071&q=80", PublishDate= DateTime.Now.AddDays(-1) },
		new Blog{Title="Sed molestie massa ut tellus lacinia porttitor. Sed at dolor urna.", Content="Nunc congue dictum enim sit amet ultrices. Donec consectetur felis ac odio rhoncus, ac mattis sem aliquet. Proin fringilla commodo ante, ut auctor risus semper ut. Morbi ut nulla pretium, pretium turpis vel, tincidunt urna. Proin porttitor finibus ultricies. Ut luctus sem lectus, sit amet sodales massa fermentum et. Nullam in suscipit sem, quis vulputate dolor. Vivamus ornare imperdiet tortor et tempus. Cras nec consequat est. In cursus nulla purus, id sodales lacus egestas et. Vivamus nunc odio, luctus quis dapibus in, cursus id lectus. ", ImageURL="https://media.istockphoto.com/id/1351292660/photo/rain-drops-on-a-black-background-the-background-can-be-remove-using-a-blending-mode-like.jpg?s=2048x2048&w=is&k=20&c=0lNumHldqqdihnnLVDQVQbLYj-DHSxSNW8T7T1Alqfk=", PublishDate= DateTime.Now.AddDays(-1) }
	};

	public static void Initialize(IServiceProvider serviceProvider)
	{
		using (var context = new RNET102DbContext(serviceProvider.GetRequiredService<DbContextOptions<RNET102DbContext>>()))
		{
            foreach (var blog in BlogSeedData)
            {
                if (context.Blogs.Any(b => b.Title != blog.Title))
                {
					context.Blogs.Add(blog);
                }
            }
			context.SaveChanges();
        }
	}
}









