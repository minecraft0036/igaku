# igaku

簡単な概要（1〜2文で）
- このリポジトリは HTML/CSS を主体とした静的サイト（Index.html）が含まれています。
- C# のソースは `CSharpSource/` フォルダに格納されています（ビルド手順は以下）。

## 構成
- Index.html — メインの静的ページ
- HTMLPage1.html — 補助的な HTML
- PageStyle.css / Style.css — スタイル
- JavaScript1.js — スクリプト（現状は空/未使用）
- CSharpSource/ — C# のソースコード（ソリューション/プロジェクトをここに置く）

## 動作確認（静的サイト）
1. リポジトリをクローン:
   ```
   git clone https://github.com/minecraft0036/igaku.git
   ```
2. ブラウザで `Index.html` を開くか、簡易的にローカルサーバで確認:
   ```
   # Python がある場合
   python -m http.server 8000
   # ブラウザで http://localhost:8000 を開く
   ```

## C# サイド（ある場合）
- `CSharpSource/` に `.sln` と `.csproj` を置いてください。ビルド例:
  ```
  cd CSharpSource
  dotnet build
  ```

## 貢献
- Issue や Pull Request は歓迎します。まず Issue で目的を共有してください。

## ライセンス
- (ここに LICENSE を記載。例: MIT)