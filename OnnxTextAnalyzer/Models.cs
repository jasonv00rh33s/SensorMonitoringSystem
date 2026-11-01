namespace OnnxTextAnalyzer;

public record Category(int Id, string Name);
public record AnalysisResult(bool IsValid, double Probability, string ErrorMessage = "");