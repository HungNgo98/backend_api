<?php

namespace App\Http\Controllers;

use App\Http\Requests\ProductRequest;
use App\Models\Product;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use Illuminate\Support\Str;

class ProductController extends Controller
{
    public function getAllProduct(Request $request)
    {
        $name = $request->input('name');
        $products = (new Product)->search($name);

        return response()->json($products, Response::HTTP_OK);
    }

    public function createProduct(ProductRequest $request)
    {
        Product::create([
            'name_product' => $request->name_product,
            'img' => $request->img,
            'price' => $request->price,
            'contents' => $request->contents,
        ]);

        return response()->json(['message' => 'Thêm thành công'], Response::HTTP_CREATED);
    }

    public function updateProduct(Request $request, $id)
    {
        $product = Product::findOrFail($id);
        $product->update([
            'name_product' => $request->name_product,
            'img' => $request->img,
            'price' => $request->price,
            'contents' => $request->contents,
        ]);

        return response()->json(['message' => 'Sửa Thành Công'], Response::HTTP_OK);
    }

    public function deleteProduct($id)
    {
        Product::find($id)->delete();

        return response()->json(['message' => 'Xóa Thành Công'], Response::HTTP_NO_CONTENT);
    }

    public function uploadImage(Request $request)
    {
        $img = '';
        if ($request->has('img')) {
            $image = $request->file('img');
            $img = '/files' . '/uploads' . '/images/' . now()->format('H-i-s-m-s-d-m-Y') . '.' . $request->file('img')->extension();
            $image->move(public_path() . '/files' . '/uploads' . '/images', $img);
        }

        return response()->json(['img' => $img], Response::HTTP_OK);
    }
}
