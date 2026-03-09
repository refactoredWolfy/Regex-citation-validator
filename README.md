# C# Citation Validator

This small C# console program counts valid academic citations in a block of text using Regular Expressions.

## Citation Format

The program checks for the following pattern:

Lastname, Firstname (Year)

Example of valid citations:

Miller, John (2020)  
Smith, Anna (2019)

Example of invalid citation:

Invalid Citation

## How it Works

1. The input text is split into individual lines.
2. Each line is trimmed to remove extra spaces.
3. A regular expression checks if the line matches the citation format.
4. Valid citations are counted and returned.

## Regex Pattern Used
