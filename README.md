# Typescript Compiler UI

![alt tag](https://raw.githubusercontent.com/Tolansky/Typescript-Compiler-UI/master/tsCompiler/TSCUI.png)

### Features

 - Automatic background compilation of .tc files
    - Triggered by saving a .tc file   
    - Only in directories you choose
 - Uses tsc command line, not independant compiler 
   - Updating tsc (e.g. through npm) should not break this
 - You **don't** have to edit tc files with Visual Studio 
 - User notification on compilation errors
 - Save 'watch list' between execution



### Requirements
- TSC
- .NET

### Don't have TSC?
- Install Node: https://nodejs.org/ 
- Use NPM (installed with Node) to install typescript:
    ```sh
    npm install -g typescript
    ```
- That's it!
### License
Apache 2.0

