﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public static class Persons {
        private static readonly Lazy<List<Person>> dataSource = new Lazy<List<Person>>(() => {
            var dataSource = new List<Person>() {
                new Person() { Id= 0 , FirstName="John", LastName="Heart", Department=Department.Electronics },
                new Person() { Id= 1 , FirstName="Samantha", LastName="Bright", Department=Department.Motors },
                new Person() { Id= 2 , FirstName="Arthur", LastName="Miller", Department=Department.Software },
                new Person() { Id= 3 , FirstName="Robert", LastName="Reagan", Department=Department.Electronics },
                new Person() { Id= 4 , FirstName="Greta", LastName="Sims", Department=Department.Motors },
                new Person() { Id= 5 , FirstName="Brett", LastName="Wade", Department=Department.Software },
                new Person() { Id= 6 , FirstName="Sandra", LastName="Johnson", Department=Department.Electronics },
                new Person() { Id= 7 , FirstName="Edward", LastName="Holmes", Department=Department.Motors },
                new Person() { Id= 8 , FirstName="Barbara", LastName="Banks", Department=Department.Software },
                new Person() { Id= 9 , FirstName="Kevin", LastName="Carter", Department=Department.Electronics },
                new Person() { Id= 10, FirstName="Cynthia", LastName="Stanwick", Department=Department.Motors },
                new Person() { Id= 11, FirstName="Sam", LastName="Hill", Department=Department.Electronics },
            };
            return dataSource;
        });
        public static List<Person> DataSource { get { return dataSource.Value; } }
    }
}
