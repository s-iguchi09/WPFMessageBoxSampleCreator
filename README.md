# WPFMessageBoxSampleCreator

Language: [English](#english) | [日本語](#japanese)

Website: [English](https://s-iguchi09.github.io/apps/wpf-messagebox-sample-creator.html) | [日本語](https://s-iguchi09.github.io/ja/apps/wpf-messagebox-sample-creator.html)

---

<a id="english"></a>
## Overview (English)

A simple WPF application that shows the text you enter in a `MessageBox`.  
You can see how a `MessageBox` will look before writing any code.

The [website](https://s-iguchi09.github.io/apps/wpf-messagebox-sample-creator.html) also shows which button becomes the default for every combination of `MessageBoxButton` and `MessageBoxResult`, measured on .NET 8 and .NET 10.

### Features

- Enter any values in the text boxes and combo boxes
- Click the button to show your input with `MessageBox.Show()`
- Set every argument of `MessageBox.Show()` independently: message text, caption, `MessageBoxButton`, `MessageBoxImage`, `MessageBoxResult` (default result), and `MessageBoxOptions`

### How to Use

1. Download the latest ZIP from the [Releases](https://github.com/s-iguchi09/WPFMessageBoxSampleCreator/releases) page
2. Extract it and run `WPFMessageBoxSampleCreator.exe` in the `WPFMessageBoxSampleCreator/Release/net8.0-windows/win-x64` or `WPFMessageBoxSampleCreator/Release/net10.0-windows/win-x64` folder, matching the installed runtime
3. Enter the message text and caption, and choose the button, icon, default result, and options
4. Click the button to show the `MessageBox`

### Requirements

| Item | Details |
|------|---------|
| OS | Windows (x64) |
| .NET | .NET 8 or .NET 10 Desktop Runtime (x64) |

The released build is framework-dependent, so the matching .NET Desktop Runtime must be installed.

### Build

```
dotnet build src/WPFMessageBoxSampleCreator.slnx
```

### License

[MIT License](LICENSE)

---

<a id="japanese"></a>
## 概要 (Japanese)

このアプリは、アプリに入力した文字列を MessageBox で表示するシンプルな WPF アプリケーションです。
どのように MessageBox されるのかを確認することができます。

[サイトのページ](https://s-iguchi09.github.io/ja/apps/wpf-messagebox-sample-creator.html)では、.NET 8 と .NET 10 で `MessageBoxButton` と `MessageBoxResult` の全組み合わせを表示し、どのボタンが既定になるかを確かめた結果も載せています。

### 主な機能

- テキストボックス、コンボボックスに任意の値を入力
- ボタンをクリックすると `MessageBox.Show()` で入力内容を表示
- `MessageBox.Show()` の引数（本文、タイトル、`MessageBoxButton`、`MessageBoxImage`、`MessageBoxResult`（既定の結果）、`MessageBoxOptions`）をそれぞれ設定できる

### 使い方

1. [Releases](https://github.com/s-iguchi09/WPFMessageBoxSampleCreator/releases) ページから最新の ZIP をダウンロード
2. 展開し、導入済みのランタイムに合わせて、`WPFMessageBoxSampleCreator/Release/net8.0-windows/win-x64` または `WPFMessageBoxSampleCreator/Release/net10.0-windows/win-x64` フォルダーの `WPFMessageBoxSampleCreator.exe` を実行
3. 本文とタイトルを入力し、ボタン・アイコン・既定の結果・オプションを選択
4. ボタンをクリックして `MessageBox` を表示

### 動作環境

| 項目 | 内容 |
|------|------|
| OS | Windows (x64) |
| .NET | .NET 8 または .NET 10 のデスクトップ ランタイム（x64） |

配布しているビルドはフレームワーク依存のため、対応する .NET デスクトップ ランタイムが導入済みである必要があります。

### ビルド

```
dotnet build src/WPFMessageBoxSampleCreator.slnx
```

### ライセンス

[MIT License](LICENSE)
