using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TodebProject.Models
{
    public class PostData 
    {
        private static List<Post> _post;
        public static List<Post> Get()
        {
            _post = new List<Post>()
            {
                new Post()
                {
                    userId = 10,
                    Id = 93,
                    title = "beatae soluta recusandae",
                    body = "dolorem quibusdam ducimus consequuntur dicta aut quo laboriosam\nvoluptatem quis enim recusandae ut sed sunt\nnostrum est odit totam\nsit error sed sunt eveniet provident qui nulla"
                },
                new Post()
                {
                    userId= 10,
                    Id=94,
                    title= "qui qui voluptates illo iste minima",
                    body= "aspernatur expedita soluta quo ab ut similique\nexpedita dolores amet\nsed temporibus distinctio magnam saepe deleniti\nomnis facilis nam ipsum natus sint similique omnis"
                },
                new Post()
                {
                    userId= 10,
                    Id= 95,
                    title= "id minus libero illum nam ad officiis",
                    body= "earum voluptatem facere provident blanditiis velit laboriosam\npariatur accusamus odio saepe\ncumque dolor qui a dicta ab doloribus consequatur omnis\ncorporis cupiditate eaque assumenda ad nesciunt"
                },
                new Post()
                {
                    userId= 10,
                    Id= 96,
                    title= "quaerat velit veniam amet cupiditate aut numquam ut sequi",
                    body= "in non odio excepturi sint eum\nlabore voluptates vitae quia qui et\ninventore itaque rerum\nveniam non exercitationem delectus aut"
                },
                new Post()
                {
                    userId= 10,
                    Id= 97,
                    title= "quas fugiat ut perspiciatis vero provident",
                    body= "eum non blanditiis soluta porro quibusdam voluptas\nvel voluptatem qui placeat dolores qui velit aut\nvel inventore aut cumque culpa explicabo aliquid at\nperspiciatis est et voluptatem dignissimos dolor itaque sit nam"
                },
                new Post()
                {
                    userId = 10,
                    Id = 98,
                    title = "beatae soluta recusandae",
                    body = "dolorem quibusdam ducimus consequuntur dicta aut quo laboriosam\nvoluptatem quis enim recusandae ut sed sunt\nnostrum est odit totam\nsit error sed sunt eveniet provident qui nulla"
                },
                new Post()
                {
                    userId= 10,
                    Id=99,
                    title= "quo qui qui voluptates illo iste minima",
                    body= "aspernatur expedita soluta quo ab ut similique\nexpedita dolores amet\nsed temporibus distinctio magnam saepe deleniti\nomnis facilis nam ipsum natus sint similique omnis"
                },
                new Post()
                {
                    userId= 10,
                    Id= 100,
                    title= "quibusdam id minus libero illum nam ad officiis",
                    body= "earum voluptatem facere provident blanditiis velit laboriosam\npariatur accusamus odio saepe\ncumque dolor qui a dicta ab doloribus consequatur omnis\ncorporis cupiditate eaque assumenda ad nesciunt"
                },
                new Post()
                {
                    userId= 10,
                    Id= 101,
                    title= "laboriosam quaerat velit veniam amet cupiditate aut numquam ut sequi",
                    body= "in non odio excepturi sint eum\nlabore voluptates vitae quia qui et\ninventore itaque rerum\nveniam non exercitationem delectus aut"
                },
                new Post()
                {
                    userId= 10,
                    Id= 102,
                    title= "excepturi sint quas fugiat ut perspiciatis vero provident",
                    body= "eum non blanditiis soluta porro quibusdam voluptas\nvel voluptatem qui placeat dolores qui velit aut\nvel inventore aut cumque culpa explicabo aliquid at\nperspiciatis est et voluptatem dignissimos dolor itaque sit nam"
                },
            };
            return _post;
        }

       
    }
}
