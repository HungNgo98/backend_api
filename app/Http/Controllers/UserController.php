<?php

namespace App\Http\Controllers;

use http\Client\Curl\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    public function getAllUser(Request $request) {
        $a = users::all();
        return response()->json($a,'200');

    }

    public function createUser(Request $request) {
        $filePath = '';
//        if ($request->has('img')) {
//            $image = $request->file('img');
//            $name = Str::slug($request->input('name')) . '_' . time();
//            $folder = '/uploads/images/';
//            $filePath = $folder . $name . '.' . $image->getClientOriginalExtension();
//            $this->uploadOne($image, $folder, 'public', $name);
//        }
        User::create([
            'name' => $request->name,
            'password'  => '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi',
            'email' => $request->price,
            'email_verified_at' => $request->email_verified_at,

        ]);

//        $validated = $request->validate([
//            'name_product' => 'required',
//            'img' => 'required',
//            'price' => 'required',
//        ]);

        return response()->json(['mess' => 'them thanh cong']);
    }

//    public function getUser(Request $request, $id) {
//        $users = users::findOrFail($id);
//        User::
//
//
//    }

    public function updateUser(Request $request, $id) {


        $users = users::findOrFail($id);

        User::update([
            'name' => $request->name,
            'password'  => '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi',
            'email' => $request->price,
            'email_verified_at' => $request->email_verified_at,

        ]);



        return response()->json(['mes'=>'sua thanh cong']);


    }

    public function deleteUser ($id) {

            $users = User::find($id);

            $users->delete();
            return response()->json(['mess' => 'xoa thanh cong']);


    }
}
