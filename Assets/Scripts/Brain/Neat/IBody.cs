﻿namespace Brain.Neat
{
  public interface IBody
  {
    void Reset();
    void Activate(double[] outputs);
    bool HasFinished();
    double[] GetInputs();

    Organism Organism { get; set; }
    int InputCount { get; }
    int OutputCount { get; }
    double Fitness { get; }
    double MaxFitness { get; }
  }
}