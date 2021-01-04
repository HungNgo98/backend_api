<?php

namespace App\Http\Controllers;

use App\Models\category;
use Illuminate\Http\Request;

class CategoryController extends Controller
{
    public function getAllCategories() {
        $a=category::all();
        return response()->json($a,200);
    }

    public function createCategories(Request $request) {

            // Validate the request...



//        $filePath = '';
//        if ($request->has('img')) {
//            $image = $request->file('img');
//            $name = Str::slug($request->input('name')) . '_' . time();
//            $folder = '/uploads/images/';
//            $filePath = $folder . $name . '.' . $image->getClientOriginalExtension();
//            $this->uploadOne($image, $folder, 'public', $name);
//        }
        category::create([
            'name' => $request->name,
            'description' => $request->description,

        ]);



        return response()->json(['mess' => 'them thanh cong']);
    }





    public function updateCategories(Request $request, $id) {
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
