using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Student:
		IEquatable<Student>
	{
		private string _name;
		private string _surname;
		private string _patronymic;

		private int _number_faculty;
		private int _number_group;
		private int _year_entry;
		private char _type_education;

		private string _type_practice;

		public Student(string? name, string? surname, string? patronymic, int number_faculty, int number_group,
			int year_entry, char type_education, string? type_practice)
		{
			if (name == null) throw new ArgumentNullException(nameof(name));

			if (surname == null) throw new ArgumentNullException(nameof(surname));

			if (patronymic == null) throw new ArgumentNullException(nameof(patronymic));

			if (type_practice == null) throw new ArgumentNullException (nameof(type_practice));

			_number_faculty = number_faculty;
			_number_group = number_group;
			_year_entry = year_entry;
			_type_education = type_education;
		}

		public string Name
		{
			get { return _name; }

			set { _name = value; }
		}

		public string Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}

		public string Patronymic
		{
			get { return _patronymic; }
			set { _patronymic = value; }
		}
		public string Type_practice
		{
			get { return _type_practice; }
			set { _type_practice = value; }
		}

		public int GetNumberCourse()
		{
			return 2023 - _year_entry;
		}

		public override string ToString()
		{
			return $"ФИО: {_surname} {_name} {_patronymic}, Учебная группа: М{_number_faculty}О-{_number_group}{_type_education}-{_year_entry}, Курс практики: {_type_practice}";
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(_name, _surname, _patronymic, _number_faculty, _number_group, _year_entry, _type_education, _type_practice);
		}

		public bool Equals(Student? obj)
		{
			if (obj == null) return false;

			if (obj is Student std)
			{
				return Equals(std);
			} else
			{
				return false;
			}
		}
	}
}
