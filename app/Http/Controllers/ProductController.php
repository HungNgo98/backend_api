<?php

namespace App\Http\Controllers;

use App\Models\Product;
use Illuminate\Http\Request;
use Illuminate\Support\Str;

class ProductController extends Controller
{
    public function getAllProducts()
    {
        $products = Product::all();
        return response()->json($products, 200);
    }

    public function createProducts(Request $request)
    {
        $filePath = '';
        if ($request->has('img')) {
            $image = $request->file('img');
            $name = Str::slug($request->input('name')) . '_' . time();
            $folder = '/uploads/images/';
            $filePath = $folder . $name . '.' . $image->getClientOriginalExtension();
            $this->uploadOne($image, $folder, 'public', $name);
        }
        Product::create([
            'name_product' => $request->name_product,
            'img' => $filePath,
            'price' => $request->price,
            'content' => $request->content ? $request->content : 'test',

        ]);

        $validated = $request->validate([
            'name_product' => 'required',
            'img' => 'required',
            'price' => 'required',
        ]);

        return response()->json(['mess' => 'them thanh cong']);
    }

    public function updateProducts(Request $request, $id)
    {
        $product = Product::findOrFail($id);
        $product->update([
            'name_product' => $request->name_product,
            'img' => $request->img,
            'price' => $request->price,
            'content' => $request->content,
        ]);
        return response()->json(['mess' => 'sua thanh cong']);
    }

    public function deleteProducts($id)
{
    $product = Product::find($id);

    $product->delete();
    return response()->json(['mess' => 'xoa thanh cong']);
}

    public function uploadOne($uploadedFile, $folder = null, $disk = 'public', $filename = null)
    {
        $name = !is_null($filename) ? $filename : Str::random(25);

        $file = $uploadedFile->storeAs($folder, $name.'.'.$uploadedFile->getClientOriginalExtension(), $disk);

        return $file;
    }
}
