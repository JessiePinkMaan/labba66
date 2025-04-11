using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Data
{
    public class ApplicationContext : DbContext
    {
            public DbSet<Roles> roles { get; set; }
            public DbSet<Users> users { get; set; }
            public DbSet<Orders> orders { get; set; }

            public ApplicationContext()
            {
                if (Database.EnsureCreated() == true)
                {
                    users.AddRange(user);
                    //roles.AddRange(role);
                    orders.AddRange(order);
                    roles.Load();
                    users.Load();
                    orders.Load();

                    this.SaveChanges();

                 //   MessageBox.Show("База данных создана и заполнена");
                }
                else
                {
                    users.Load();
                    roles.Load();
                    orders.Load();
                   // MessageBox.Show("База данных уже существует");
                    Debug.WriteLine("База данных уже существует");
                }

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=lolbd1.bd");

            }
              
            //List<Roles> role = new()
            //    {
            //        new Roles
            //        {
                    
            //           Name = "user"
            //        },
            //         new Roles
            //        {
                     
            //            Name = "Admin"

            //        }
            //    };

            List<Users> user = new()
                {
                    new Users
                    {
                        Login = "123",
                        Password = "123"
                    },
                     new Users
                    {
                        Login = "0",
                        Password = "000",
                        roles = new Roles { Name = "Admin" }

                    }
                };
            
         
            List<Orders> order = new()
                    {
                        new Orders
                        {
                            numberOfOrder = 1,
                            typeOfGoods = "lol",
                            weightOne = 1,
                            volumeOfUnit = 2,
                            distance = "lol",
                            quantity = 3,
                            name = "hahahaha",
                            phoneNumber = "79943433324",
                            status = "nono"
                        },

                        //  new Orders
                        //{
                        //    numberOfOrder = 2,
                        //    typeOfGoods = "kek",
                        //    weightOne = 1,
                        //    volumeOfUnit = 2,
                        //    distance = "kekowitch",
                        //    quantity = 3,
                        //    name = "hihihihi",
                        //    phoneNumber = "79943433324",
                        //    status = "nana"
                        //}

                    };
        }
    }

