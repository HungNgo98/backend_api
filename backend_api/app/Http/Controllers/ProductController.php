<?php

namespace App\Http\Controllers;

use App\Http\Requests\ProductRequest;
use App\Models\Product;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use Illuminate\Support\Str;

class ProductController extends Controller
{
    public function getAllProduct()
    {
        // thêm phân trang
        $products = Product::all();

        return response()->json($products, Response::HTTP_OK);
    }

    public function createProduct(ProductRequest $request)
    {
        $name = '';
        if ($request->has('img')) {
            $image = $request->file('img');
            $name = 'files/' . now()->format('H-i-s-m-s-d-m-Y') . $request->file('img')->extension();
            $image->move(public_path() . '/files' . '/uploads' . '/images', $name);
        }
        Product::create([
            'name_product' => $request->name_product,
            'img' => $name,
            'price' => $request->price,
            'contents' => $request->contents,
        ]);

        return response()->json(['message' => 'them thanh cong'], Response::HTTP_CREATED);
    }

    public function updateProduct(Request $request, $id)
    {

        // xử lý upload ảnh
        $product = Product::findOrFail($id);
        $product->update([
            'name_product' => $request->name_product,
            'img' => $request->img,
            'price' => $request->price,
            'contents' => $request->contents,
        ]);

        return response()->json(['message' => 'sua thanh cong'], Response::HTTP_OK);
    }

    public function deleteProduct($id)
    {
        Product::find($id)->delete();

        return response()->json(['message' => 'xoa thanh cong'], Response::HTTP_NO_CONTENT);
    }
}
