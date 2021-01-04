<?php

namespace App\Http\Controllers;


use App\Models\category;
use Illuminate\Http\Request;
use Illuminate\Validation;
use App\Http\Requests\CategoryRequest;

class CategoryController extends Controller
{
    public function getAllCategories() {
        $a=category::all();
        return response()->json($a,200);
    }
    public function createCategories(CategoryRequest $request) {
        category::create([
            'name' => $request->name,
            'description' => $request->description,

        ]);
        return response()->json(['mess' => 'them thanh cong']);
    }
    public function updateCategories(CategoryRequest $request, $id) {
        $category = category::findOrFail($id);
        $category->update([
            'name' => $request->name,
            'description' => $request->description,
        ]);
        return response()->json(['mess' => 'sua thanh cong']);
    }
    public function deleteCategories($id) {
        $product = category::find($id);

        $product->delete();
        return response()->json(['mess' => 'xoa thanh cong']);
    }
}
