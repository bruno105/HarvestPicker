﻿namespace HarvestPicker.Api.Response;

public class Line
{
    public string CurrencyTypeName { get; set; }
    public ExchangeRate Pay { get; set; }
    public ExchangeRate Receive { get; set; }
    public SparkLine PaySparkLine { get; set; }
    public SparkLine ReceiveSparkLine { get; set; }
    public SparkLine LowConfidencePaySparkLine { get; set; }
    public SparkLine LowConfidenceReceiveSparkLine { get; set; }
    public double ChaosEquivalent { get; set; }
    public string DetailsId { get; set; }
}