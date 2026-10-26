---
name: release-build
description: >-
  Build SourceGit in Release and write binaries to the repository root out
  directory. Use when the user asks to build, compile, rebuild, 编译, or
  重新编译 this project.
---

# Release build

在仓库根目录执行。build 过程用 Release build，输出目录为根目录 `/out` 目录。

```sh
dotnet build src/SourceGit.csproj -c Release -o out
```

- 配置固定为 `Release`。不要用 `Debug`，不要省略 `-c`。
- 在仓库根目录执行，让 `-o out` 指向根目录的 `out`。不要输出到默认的 `src/bin`。
- 只构建 `src/SourceGit.csproj`。引用项目的程序集也会出现在 `out`，这是正常的。
- `out/` 已在 `.gitignore` 中，不要提交，也不要把它加进 git。
- 日志里的 `fatal: No names found, cannot describe anything` 来自 `git describe`，项目忽略了它的退出码，不算构建失败。
- 成功标准是 `Build succeeded` 且 0 Error。主程序是 `out/SourceGit.exe`。
- 用户只要求 build 时，不要改成 `dotnet publish`。
