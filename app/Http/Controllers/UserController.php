<?php

namespace App\Http\Controllers;

use App\Http\Requests\UserRequest;
use App\Models\User;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use Illuminate\Support\Facades\Hash;


class UserController extends Controller
{
    public function getAllUser(Request $request) {
        $a = User::all();
        return response()->json($a, Response::HTTP_OK);

    }

    public function createUser(UserRequest $request) {

        User:: create([
            'name' => $request->name ,
            'sex'=> $request->sex,
            'password'  => Hash::make($request->newPassword),
            'email' => $request->email,
            'email_verified_at' => now()


        ]);

        return response()->json(['mess' => 'them thanh cong'], Response::HTTP_CREATED);
    }



    public function updateUser(UserRequest $request, $id) {


        $users = User::findOrFail($id);

        $users->update([
            'name' => $request->name,
            'sex'=> $request->sex,
            'password'  => Hash::make($request->newPassword),
            'email' => $request->email,
            'email_verified_at' => now()

        ]);

        return response()->json(['mes'=>'sua thanh cong'], Response::HTTP_OK);


    }

    public function deleteUser ($id) {

            $users = User::find($id);

            $users->delete();

            return response()->json(['mess' => 'xoa thanh cong'], Response::HTTP_NO_CONTENT);
    }
}

