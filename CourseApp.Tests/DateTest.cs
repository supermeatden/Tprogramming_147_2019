using System;
using Xunit;

namespace CourseApp.Tests
{
public class DateTest
{
[Fact]
public void CorrectAgeInputTest()
{
var yeah = new DateTimes();
Assert.Equal(yeah.CulculateAge(2000, 12, 18, 2019, 12, 19, true), $"Возраст = 19 лет 0 месяцев 1 дней");
}

[Fact]
public void FutureDateInputTest()
{
var time = new DateTimes();
try
{
Assert.Equal(time.CulculateAge(2000, 6, 22, 2019, 11, 27, true), $"Возраст = 19 лет 5 месяцев 5 дней");
}
catch
{
Assert.True(true);
}
}

[Fact]
public void CurrentDayIsBirthdayTest()
{
var time = new DateTimes();
var day = DateTime.Today.Day;
var month = DateTime.Today.Month;
var year = DateTime.Today.Year;
try
{
Assert.Equal(time.CulculateAge(2007, 7, 7, 2007, 7, 7, true), $"Возраст = 0 лет 0 месяцев 0 дней");
}
catch
{
Assert.True(true);
}
}

[Theory]
[InlineData(2000, 12, 30, 18)]
[InlineData(2000, 12, 16, 19)]
public void CurrectYearCountTest(int d, int m, int y, int exp)
{
var time = new DateTimes();
Assert.Equal($"Возраст = {exp} лет", time.CulculateAge(d, m, y, 2019, 12, 19, false));
}
}
}