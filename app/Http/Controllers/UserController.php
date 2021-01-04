<?php

namespace App\Http\Controllers;

use App\Models\Product;
use App\Models\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    public function getAllUser(Request $request) {
        $a = User::all();
        return response()->json($a,'200');

    }

    public function createUser(Request $request) {

        User:: create([
            'name' => $request->name ,
            'sex'=> $request->sex,
            'password'  => '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi',
            'email' => $request->email,
            'email_verified_at' => $request->email_verified_at,

        ]);


        return response()->json(['mess' => 'them thanh cong']);
    }

//

    public function updateUser(Request $request, $id) {


        $users = User::findOrFail($id);

        $users->update([
            'name' => $request->name,
            'sex'=> $request->sex,
            'password'  => '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi',
            'email' => $request->email,
            'email_verified_at' => $request->email_verified_at,

        ]);



        return response()->json(['mes'=>'sua thanh cong']);


    }

    public function deleteUser ($id) {

            $users = User::find($id);

            $users->delete();
            return response()->json(['mess' => 'xoa thanh cong']);


    }
    public function store(Request $request)
    {
        $validatedData = $request->validate([
            'name' => ['required', 'unique:posts', 'max:255'],
            'email' => ['unique'],
            'password' => ['required','min:8'],

        ]);
    }

}

