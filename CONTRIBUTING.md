# Contributing Guidelines
rhythm.Nexus is a game driven by the community, and every contribution changes the game.

## How to Contribute
- Code Contribution
- Documentation Improvements
- Reporting Issues
- Recommending Features/Ideas

## Development Environment
### Prerequisites
- git
- Knowledge of git
- Basic Knowledge of C#
- Familiar to the git workflow
### Code Editor
You may use any code editor you like, but it is recommended to use 
- Visual Studio
- JetBrains Rider
- Visual Studio Code with the extensions EditorConfig and C# Dev Kit.

## Code Quality/Standards
## Variables
When naming variables, if it has 2 words, like:
```
nexusName
```
The first word is always lowercase. And the words beyond that, begin with uppercase.
### Comments
Leave comments on anything you may think that other people may not understand. i.e. nexus abstraction, etc.
### Curly Brackets
For curly brackets, please use the following syntax:
```csharp
void foo() {
  bar()
}
```
and avoid the following syntax:
```csharp
void foo()
{
  bar()
}
```

## Submitting your Changes
1. Fork this repository.
2. Create a new branch for your changes.
3. Commit your changes with clear messages.
4. Open a pull request and link any related issues or discussions.
### When Submitting Changes
- **Do NOT** merge from the forked repo's master.  
- **Do NOT** update your PR from master. We will do this for you when we merge your PR.

## Reviewing
All PRs will be reviewed. You may be asked to change some things before merging. This is normal.

## Licensing
By contributing, you agree that your contributions will be licensed under the MIT License.

## Request Changes to CONTRIBUTING.md
Please open a discussion to change CONTRIBUTING.md.
