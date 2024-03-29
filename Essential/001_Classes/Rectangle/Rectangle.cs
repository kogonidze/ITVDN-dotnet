﻿namespace RectangleExercise;

internal class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double Area
    {
        get => AreaCalculator(side1, side2);
    }

    public double Perimeter
    {
        get => PerimeterCalculator(side1, side2);
    }

    public string ShowInfo()
        => $"Rectangle with side1 = {side1}, side2 = {side2}. " +
        $"Area = {Area}, Perimeter = {Perimeter}.";

    private double AreaCalculator(double side1, double side2)
        => side1 * side2;

    private double PerimeterCalculator(double side1, double side2)
        => (side1 + side2) * 2;
}
