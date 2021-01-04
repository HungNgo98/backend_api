<?php

namespace App\Http\Controllers;

use App\Http\Requests\UserRequest;
use App\Models\Product;
use App\Models\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    public function getAllUser(Request $request) {
        $a = User::all();
        return response()->json($a,'200');

    }

    public function createUser(UserRequest $request) {

        User:: create([
            'name' => $request->name ,
            'sex'=> $request->sex,
            'password'  => $request->password,
            'password_confirmation'=> $request->password,
            'email' => $request->email,
            'email_verified_at' => now()


        ]);


//        $validated = $request->validated();
        return response()->json(['mess' => 'them thanh cong']);
    }

//

    public function updateUser(Request $request, $id) {


        $users = User::findOrFail($id);

        $users->update([
            'name' => $request->name,
            'sex'=> $request->sex,
            'password'  => $request->password,
            'password_confirmation'=> $request->password,
            'email' => $request->email,
            'email_verified_at' => now()

        ]);



        return response()->json(['mes'=>'sua thanh cong']);


    }

    public function deleteUser ($id) {

            $users = User::find($id);

            $users->delete();
            return response()->json(['mess' => 'xoa thanh cong']);


    }

}

