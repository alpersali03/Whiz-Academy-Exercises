#include<stdio.h>
struct Universtiy {
	char name[30];

};

struct Student {
	int age;
	char name[10];
	float mark;
	struct Universtiy uni;
};

void InsertInStudents(struct Student  students[3]);
void PrintStudents(struct Student  students[2]);
int main() {

	struct Student students[2];
	InsertInStudents(students);
	PrintStudents(students);

	return 0;
}

void InsertInStudents(struct Student  students[3])
{
	for (int i = 0; i < 2; i++)
	{
		students[i].age = 10;
		scanf_s("%d", &students[i].age);

		scanf_s("%s", students[i].name,20);

		students[i].mark = 5, 50;
		scanf_s("%d", &students[i].mark);

		scanf_s("%s", students[i].uni.name,20);

	}
}

void PrintStudents(struct Student  students[2])
{
	for (int i = 0; i < 2; i++)
	{
		printf("%d %.2f %s %s", students[i].age, students[i].mark, students[i].name, students[i].uni.name);
	}
}
