<?php

namespace App\Http\Controllers;


use App\Models\Category;
use App\Http\Requests\CategoryRequest;
use Illuminate\Http\Response;
class CategoryController extends Controller
{
    public function getAllCategories() {
        $a=Category::all();
        return response()->json($a,Response::HTTP_OK);
    }
    public function createCategory(CategoryRequest $request) {
        Category::create([
            'name' => $request->name,
            'description' => $request->description,
        ]);

        return response()->json(['messenge' => 'them thanh cong'],Response::HTTP_CREATED);
    }
    public function updateCategory(CategoryRequest $request, $id) {
        $Category = Category::findOrFail($id);
        $Category->update([
            'name' => $request->name,
            'description' => $request->description,
        ]);

        return response()->json(['message' => 'sua thanh cong'],Response::HTTP_OK);
    }
    public function deleteCategory($id) {
        $product = Category::findOrFail($id);

        $product->delete();

        return response()->json(['message' => 'xoa thanh cong'],Response::HTTP_NO_CONTENT);
    }
}
