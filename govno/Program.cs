class HomeLibrary
  {
      public string NameBook { get; set; }
      public string BookAuthor { get; set; }
      public int YearIssue { get; set; }

      public void Info()
      {
          Console.WriteLine($"Название книги: {NameBook}");
          Console.WriteLine($"Автор: {BookAuthor}");
          Console.WriteLine($"Год выпуска: {YearIssue}\n");
      }
  }


  class HomeLibrary2
  {
      static void Main()
      {
          List<HomeLibrary> library = new List<HomeLibrary> { };
          int a = -1;
          int year = 0;
          while (a != 0)
          {
              Console.WriteLine("Выберите опцию\n\n1 - вывести данные библиотеки\n2 - добавить книгу в библиотеку\n3 - удалить книгу из библиотеки\n4 - Найти книгу по году издания\n5 - Отсортировать книгу по...\n0 - выход ");
              a = Convert.ToInt32(Console.ReadLine());
              switch (a)
              {
                  case 1:
                      for (int i = 0; i < library.Count; i++)
                      {
                          Console.WriteLine($"Индекс книги: {i}");
                          library[i].Info();
                          Console.WriteLine("------------------------");
                      }
                      break;
                  case 2:

                      Console.Write("Введите название книги: ");
                      string book = Console.ReadLine()!;
                      Console.Write("Введите автора книги: ");
                      string author = Console.ReadLine()!;
                      Console.Write("Введите год выпуска книги: ");
                      year = Convert.ToInt32(Console.ReadLine());
                      HomeLibrary newbook = new HomeLibrary { NameBook = book, BookAuthor = author, YearIssue = year };
                      library.Add(newbook);
                      break;
                  case 3:
                      Console.WriteLine($"Выбирете книгу для удаления от 0 до {library.Count - 1}: ");
                      int removeIndexBook = Convert.ToInt32(Console.ReadLine());
                      library.RemoveAt(removeIndexBook);
                      break;
                  case 4:
                      Console.WriteLine("Введите год книги: ");
                      year = Convert.ToInt32(Console.ReadLine());
                      var homeLibrary = library.Where(x => x.YearIssue == year).FirstOrDefault();
                      if (homeLibrary != null)
                      {
                          Console.WriteLine($"Книга с таким годом:");

                          homeLibrary.Info();
                      }
                      else
                      {
                          Console.WriteLine("Книга с таким годом не найдена\n");
                      }
                      break;
                  case 5:
                      Console.WriteLine("\n1 - Отсортировать по названию\n2 - Отсортировать по автору\n3 - Отсортировать по году");
                      int b = Convert.ToInt32(Console.ReadLine());
                      switch (b)
                      {
                          case 1:
                              library = library.OrderBy(b => b.NameBook).ToList();
                              break;
                          case 2:
                              library = library.OrderBy(a => a.BookAuthor).ToList();
                              break;
                          case 3:
                              library = library.OrderBy(y => y.YearIssue).ToList();
                              break;

                      }
                      Console.WriteLine("Отсортированная библиотека:");
                      for (int i = 0; i < library.Count; i++)
                      {
                          library[i].Info();
                          Console.WriteLine("------------------------------");
                      }
                      break;

              }
          }
      }
  }
