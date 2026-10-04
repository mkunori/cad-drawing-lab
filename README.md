# CadDrawingLab

C# / Windows Forms / ACadSharpを学習するための個人学習プロジェクトです。
GitHubリポジトリ名は `cad-drawing-lab` です。

リポジトリ: [mkunori/cad-drawing-lab](https://github.com/mkunori/cad-drawing-lab)

## 目的

- C# / Windows Formsを学習する
- ACadSharpを使用したDWG生成を学習する
- Windows Forms画面から数値を入力する
- 入力値から2D / 3D CAD図形を生成する
- DWGを出力する
- DWG TrueViewを起動して生成結果を確認する
- 将来的には簡単な橋梁部材の生成まで行う

これらは今後の学習目標です。現在は空のフォームを起動する初期状態で、
数値入力、CAD図形生成、DWG出力、DWG TrueView起動、学習課題は未実装です。
ACadSharpのNuGetパッケージもまだ追加していません。

## 開発環境

- Windows
- .NET 10 SDK（ターゲット: `net10.0-windows`）
- このターゲットと `.slnx` 形式に対応するVisual Studio
- Visual Studioの「.NET デスクトップ開発」ワークロード

DWG TrueViewは、生成結果の確認を実装する段階で用意します。

## 最小構成

```text
CadDrawingLab.slnx     ソリューション
CadDrawingLab.csproj   Windows Formsプロジェクト
Program.cs            起動処理
Form1.cs              空のフォームのコード
Form1.Designer.cs      Windows Forms Designerが管理するコード
Form1.resx             フォームのリソース
```

実装者本人がVisual StudioのWindows Forms Designerで画面を作り、
C#コードを実装していきます。現時点ではクラスやフォルダを追加せず、
既存の `Form1` を維持しています。

## ビルド・実行

Visual Studioで `CadDrawingLab.slnx` を開き、ソリューションをビルドします。
F5でデバッグ実行すると空のフォームが表示されます。

コマンドラインでのビルド:

```powershell
dotnet build CadDrawingLab.slnx
```

`.vs/`、`bin/`、`obj/`、`*.user` などのローカル設定・生成物は
`.gitignore` でGit管理対象から除外します。
`Form1.Designer.cs` と `Form1.resx` は画面の再現に必要なため管理対象です。

## 次の作業

1. Visual Studioでビルド・起動し、Windows Forms Designerで `Form1` を開く。
2. Designerで数値入力欄やボタンを配置し、イベント処理を自分で実装する。
3. CAD処理に進む段階でACadSharpをNuGetから追加する。
4. 図形生成、DWG出力、DWG TrueViewでの確認を順に学習・実装する。

Designerが管理するコードは、原則としてDesignerから編集します。
