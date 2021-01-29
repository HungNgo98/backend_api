<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Product extends Model
{
    use HasFactory;

    protected $table = 'products';

    protected $fillable = ['name_product', 'img', 'price', 'contents'];

    public function search($name)
    {
        return $this->when($name, function ($p) use ($name) {
                $p->where('name_product', 'like', '%' . $name . '%');
            })->paginate(5);
    }
}
