# Into the Future of Coding, with GitHub Copilot

## Overview
**_Did you know that devs & data scientists who leverage AI regularly can complete complex tasks almost 55.8% faster & better than regular devs?_** 🤯

If you're curious and wish to learn how to use AI effectively as your pair programmer, then you won’t want to miss this session!

In under 60 minutes, we'll walk through real examples of GitHub Copilot accelerating and enhancing the following workflows in a jiffy:
- Writing entire functions and algorithms
- Understanding complex code
- Finding time complexity & optimizing code
- Debugging and fixing issues in the code
- Writing a full range of tests for your code
- Performing complex data analysis and visualization
- Writing effective documentation for your code

## Demo 0 - Navigating Around

- Use `0.NavigatingAround.js`
- Type the following, then hit `[Space]`:
    ```js
    // Get today's date & current time
    var
- Show how to accept suggestions using `[TAB]` (full accept) or `[Ctrl + ->]` (partial accept)

## Demo 1 - Code Generation

### Function Generation

- Use `1.1.CodeGen_Function.cs`
- Empty C# class already present
- Type the following comment, then hit `[Enter]`:
    ```cs
    // Write a function to validate if the input string is a properly formatted email address
    ```

### Full Algorithm Generation

- Use `1.2.CodeGen_Algo.cpp`
- Open Copilot Chat using `[Ctrl + I]` & type the following: `Code up a graph data structure and implement Dijkstra's algorithm`

### Code Generation for Data Science Scenarios

- Inspect the data in `1.3.CodeGen_DataViz.data.csv`, containing daily stock prices over several years
- Use `1.3.CodeGen_DataViz.py`
- Open Copilot Chat using `[Ctrl + I]` & type the following:
    ```
    Load the data present in 1.3.CodeGen_DataViz.data.csv containing Microsoft stock prices in the form of Date, Open, High, Low, Close, Adj Close, Volume. Perform EDA on this data, visualize the last 5 years of data (sample appropriately to avoid clutter)
    ```
- Potential Errors:
    - File Path may be incorrect - replace the `/` with `\\`
    - Data may not be sorted by date - Prompt Copilot to sort the data by date
- [Optional] Type the following now to show how this data can be converted into features & target to train an ML model for stock price prediction:
    ```
    Slice this data into rolling windows of 7 days. For each window utilize the closing price as both a feature & target variable, where the first 6 days act as features & event day acts as the target. Split this data into training & test sets in 9:1 ratio

    Use the training set for training a linear regression model

    Test this model on the test set & report the mean squared error  & the R^2 score for the test period.

    Plot the actual vs predicted values.
    ```

## Demo 2 - Code Understanding

- Use `2.CodeUnderstanding.cs`
- Obfuscated code, difficult to read & understand
- Right-click, hover over "Copilot" & select **Explain this**
- It explains that this actually is obfuscated code implementing Quick-Sort algorithm

## Demo 3 - Time Complexity & Code Optimization

- Use `3.TimeComplexityOptimization.cpp`
- This is an unoptimized version of code to find all triplets in a list that sum to zero
- Select the code, hit `[Ctrl + I]` & type the following: `Obtain the time complexity`
- Having the code selected & Copilot Chat open, type: `Optimize this code to have the best possible time complexity`

## Demo 4 - Code Debugging

- Use `4.Debugging.py`
- Run it - It should gives `RecursionError: maximum recursion depth exceeded while calling a Python object`
- Select all the code, right click, hover on "Copilot" & select **Fix it**
- Run again to show that the code is fixed

## Demo 5 - Testing

### Test Python Code

- Use `5.1.Testing.py`
- The code is a basic implementation of a shopping cart
- Hit `[Ctrl + I]` & type the following: `Write unit tests for the code`

### Test C# Code (Using Specific Framework)

- Use `5.2.Testing.cs`
- The code is the same shopping cart implementation, now in C#
- Right-click, hover over "Copilot" & select **Generate tests**
- In the new test file, if the tests are not in `NUnit` framework, open Copilot Chat & prompt: `Write these tests using NUnit framework`

## Demo 6 - Documentation

### Python Code
- Use `5.1.Testing.py`
- Select all code, hover over "Copilot" & select **Generate docs**
- _Class & all functions get docstring documentation_

### C# Code
- Use `5.2.Testing.cs`
- Select all code, hover over "Copilot" & select **Generate docs**
- _Only documentation for class gets generated. For functions, select each function & repeat_

## Demo 7 - Learning Technical Topics

- Idea is to set up Azure Pipelines for this repo, but you have no clue about what they are or how to set them up
- Open Copilot Chat & ask the following:
    - What are azure pipelines?
    - How can I set up azure pipelines for this folder? _(this may set up the YAML file only for a specific language instead of all 3 languages used in this repo)_
    - My folder also includes [other languages] files. How do I include those in my azure pipeline?

## Demo 8 - Text Processing

- Use `8.TextProcessing.txt`
- This contains some rows from `1.3.CodeGen_DataViz.data.csv`
- Hit `[Ctrl + I]` & type the following:
    ```
    Convert the dates into DD/MM/YYYY format.
    Maintain only the (Open - Close) values in the 2nd column, along with the Volume.
    Remove all other columns
    Add an index column starting from 51 at the beginning.
    Convert this into a markdown format table.
    ```

---

Created with ❣️ by [Tezan Sahu](https://www.linkedin.com/in/tezan-sahu/)